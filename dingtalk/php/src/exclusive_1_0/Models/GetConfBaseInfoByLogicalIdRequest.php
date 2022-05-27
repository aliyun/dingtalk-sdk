<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConfBaseInfoByLogicalIdRequest extends Model
{
    /**
     * @description 会议id
     *
     * @var string
     */
    public $logicalConferenceId;
    protected $_name = [
        'logicalConferenceId' => 'logicalConferenceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->logicalConferenceId) {
            $res['logicalConferenceId'] = $this->logicalConferenceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConfBaseInfoByLogicalIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['logicalConferenceId'])) {
            $model->logicalConferenceId = $map['logicalConferenceId'];
        }

        return $model;
    }
}
