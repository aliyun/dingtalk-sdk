<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCandidateByPhoneNumberResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $candidateId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'candidateId' => 'candidateId',
        'name'        => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateId) {
            $res['candidateId'] = $this->candidateId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCandidateByPhoneNumberResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateId'])) {
            $model->candidateId = $map['candidateId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
