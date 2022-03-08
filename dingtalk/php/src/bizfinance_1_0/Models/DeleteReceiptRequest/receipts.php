<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\DeleteReceiptRequest;

use AlibabaCloud\Tea\Model;

class receipts extends Model
{
    /**
     * @description 单据唯一编号
     *
     * @var string
     */
    public $code;

    /**
     * @description 修改者工号
     *
     * @var string
     */
    public $deleteUserId;

    /**
     * @description 单据类型：1付款单，2收款单
     *
     * @var int
     */
    public $receiptType;
    protected $_name = [
        'code'         => 'code',
        'deleteUserId' => 'deleteUserId',
        'receiptType'  => 'receiptType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->deleteUserId) {
            $res['deleteUserId'] = $this->deleteUserId;
        }
        if (null !== $this->receiptType) {
            $res['receiptType'] = $this->receiptType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receipts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['deleteUserId'])) {
            $model->deleteUserId = $map['deleteUserId'];
        }
        if (isset($map['receiptType'])) {
            $model->receiptType = $map['receiptType'];
        }

        return $model;
    }
}
