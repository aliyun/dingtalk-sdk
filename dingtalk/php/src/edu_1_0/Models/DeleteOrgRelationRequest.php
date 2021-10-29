<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteOrgRelationRequest extends Model
{
    /**
     * @var string
     */
    public $targetCorpId;

    /**
     * @var string
     */
    public $authCode;
    protected $_name = [
        'targetCorpId' => 'targetCorpId',
        'authCode'     => 'authCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteOrgRelationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }

        return $model;
    }
}
