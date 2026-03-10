<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConvertResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $taskBizId;
    protected $_name = [
        'taskBizId' => 'taskBizId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskBizId) {
            $res['taskBizId'] = $this->taskBizId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConvertResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskBizId'])) {
            $model->taskBizId = $map['taskBizId'];
        }

        return $model;
    }
}
