﻿using NServiceBus;


public class TransactionConfig
{
    public void Simple()
    {
        #region TransactionConfigV5

        //Enable
        Configure.With(builder => builder.Transactions(transactionSettings => transactionSettings.Enable()));

        // Disable
        Configure.With(builder => builder.Transactions(transactionSettings => transactionSettings.Disable()));

        #endregion
    }

}