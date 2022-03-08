<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBranchAuthDataRequest extends Model
{
    /**
     * @description 查询条件
     *
     * @var string[]
     */
    public $body;

    /**
     * @description 分支组织corpId
     *
     * @var string
     */
    public $branchCorpId;

    /**
     * @description 数据编码
     *
     * @var string
     */
    public $code;
    protected $_name = [
        'body'         => 'body',
        'branchCorpId' => 'branchCorpId',
        'code'         => 'code',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->branchCorpId) {
            $res['branchCorpId'] = $this->branchCorpId;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBranchAuthDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }
        if (isset($map['branchCorpId'])) {
            $model->branchCorpId = $map['branchCorpId'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }

        return $model;
    }
}
