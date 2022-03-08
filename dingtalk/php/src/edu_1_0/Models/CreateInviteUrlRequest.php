<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateInviteUrlRequest extends Model
{
    /**
     * @var string
     */
    public $authCode;

    /**
     * @var string
     */
    public $targetCorpId;

    /**
     * @var string
     */
    public $targetOperator;
    protected $_name = [
        'authCode'       => 'authCode',
        'targetCorpId'   => 'targetCorpId',
        'targetOperator' => 'targetOperator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->targetOperator) {
            $res['targetOperator'] = $this->targetOperator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateInviteUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['targetOperator'])) {
            $model->targetOperator = $map['targetOperator'];
        }

        return $model;
    }
}
