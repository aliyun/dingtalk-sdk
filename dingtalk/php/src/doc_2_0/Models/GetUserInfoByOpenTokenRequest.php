<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserInfoByOpenTokenRequest extends Model
{
    /**
     * @description 文档docKey，标识一篇文档的key。
     *
     * @var string
     */
    public $docKey;

    /**
     * @description 文档颁发给三方应用的 OpenToken，用于三方应用在文档中的免登。
     *
     * @var string
     */
    public $openToken;
    protected $_name = [
        'docKey'    => 'docKey',
        'openToken' => 'openToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docKey) {
            $res['docKey'] = $this->docKey;
        }
        if (null !== $this->openToken) {
            $res['openToken'] = $this->openToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserInfoByOpenTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docKey'])) {
            $model->docKey = $map['docKey'];
        }
        if (isset($map['openToken'])) {
            $model->openToken = $map['openToken'];
        }

        return $model;
    }
}
