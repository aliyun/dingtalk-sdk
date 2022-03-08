<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishRequest;

use AlibabaCloud\Tea\Model;

class attachExtractDecisionInfo extends Model
{
    /**
     * @var string[]
     */
    public $blackWords;

    /**
     * @var string[]
     */
    public $candidateWords;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $deptIds;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'blackWords'     => 'blackWords',
        'candidateWords' => 'candidateWords',
        'corpId'         => 'corpId',
        'deptIds'        => 'deptIds',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackWords) {
            $res['blackWords'] = $this->blackWords;
        }
        if (null !== $this->candidateWords) {
            $res['candidateWords'] = $this->candidateWords;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachExtractDecisionInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackWords'])) {
            if (!empty($map['blackWords'])) {
                $model->blackWords = $map['blackWords'];
            }
        }
        if (isset($map['candidateWords'])) {
            if (!empty($map['candidateWords'])) {
                $model->candidateWords = $map['candidateWords'];
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
