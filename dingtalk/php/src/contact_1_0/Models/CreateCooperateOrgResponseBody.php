<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCooperateOrgResponseBody extends Model
{
    /**
     * @description result
     *
     * @var string
     */
    public $cooperateCorpId;
    protected $_name = [
        'cooperateCorpId' => 'cooperateCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cooperateCorpId) {
            $res['cooperateCorpId'] = $this->cooperateCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCooperateOrgResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cooperateCorpId'])) {
            $model->cooperateCorpId = $map['cooperateCorpId'];
        }

        return $model;
    }
}
