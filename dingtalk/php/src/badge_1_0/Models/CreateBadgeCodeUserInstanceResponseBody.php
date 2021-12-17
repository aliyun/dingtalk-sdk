<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateBadgeCodeUserInstanceResponseBody extends Model
{
    /**
     * @description 码ID
     *
     * @var string
     */
    public $codeId;

    /**
     * @description 码详情跳转地址
     *
     * @var string
     */
    public $codeDetailUrl;
    protected $_name = [
        'codeId'        => 'codeId',
        'codeDetailUrl' => 'codeDetailUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeId) {
            $res['codeId'] = $this->codeId;
        }
        if (null !== $this->codeDetailUrl) {
            $res['codeDetailUrl'] = $this->codeDetailUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBadgeCodeUserInstanceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeId'])) {
            $model->codeId = $map['codeId'];
        }
        if (isset($map['codeDetailUrl'])) {
            $model->codeDetailUrl = $map['codeDetailUrl'];
        }

        return $model;
    }
}
