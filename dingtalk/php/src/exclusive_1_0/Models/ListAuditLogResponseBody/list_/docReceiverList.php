<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody\list_;

use AlibabaCloud\Tea\Model;

class docReceiverList extends Model
{
    /**
     * @description 成员名称
     *
     * @var string
     */
    public $receiverName;

    /**
     * @description 成员类型
     *
     * @var int
     */
    public $receiverType;

    /**
     * @description 成员类型翻译值
     *
     * @var string
     */
    public $receiverTypeView;
    protected $_name = [
        'receiverName'     => 'receiverName',
        'receiverType'     => 'receiverType',
        'receiverTypeView' => 'receiverTypeView',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverType) {
            $res['receiverType'] = $this->receiverType;
        }
        if (null !== $this->receiverTypeView) {
            $res['receiverTypeView'] = $this->receiverTypeView;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return docReceiverList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverType'])) {
            $model->receiverType = $map['receiverType'];
        }
        if (isset($map['receiverTypeView'])) {
            $model->receiverTypeView = $map['receiverTypeView'];
        }

        return $model;
    }
}
