<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponseBody\result;

use AlibabaCloud\Tea\Model;

class unsealClosingAccountModel extends Model
{
    /**
     * @description 解封时间点
     *
     * @var int
     */
    public $invalidTimeStamp;
    protected $_name = [
        'invalidTimeStamp' => 'invalidTimeStamp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invalidTimeStamp) {
            $res['invalidTimeStamp'] = $this->invalidTimeStamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unsealClosingAccountModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invalidTimeStamp'])) {
            $model->invalidTimeStamp = $map['invalidTimeStamp'];
        }

        return $model;
    }
}
