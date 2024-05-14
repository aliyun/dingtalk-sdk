<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserLastMetricRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $unionIdList;
    protected $_name = [
        'unionIdList' => 'unionIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionIdList) {
            $res['unionIdList'] = $this->unionIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserLastMetricRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionIdList'])) {
            if (!empty($map['unionIdList'])) {
                $model->unionIdList = $map['unionIdList'];
            }
        }

        return $model;
    }
}
