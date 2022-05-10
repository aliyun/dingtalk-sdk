<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLastOrgAuthDataRequest extends Model
{
    /**
     * @description 企业的corpId
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'targetCorpId' => 'targetCorpId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLastOrgAuthDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
