<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SpecialRuleBatchReceiverResponseBody;

use AlibabaCloud\Tea\Model;

class rows extends Model
{
    /**
     * @var string
     */
    public $serialNumber;

    /**
     * @var string
     */
    public $msgId;
    protected $_name = [
        'serialNumber' => 'serialNumber',
        'msgId' => 'msgId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->serialNumber) {
            $res['serialNumber'] = $this->serialNumber;
        }
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rows
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['serialNumber'])) {
            $model->serialNumber = $map['serialNumber'];
        }
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }

        return $model;
    }
}
