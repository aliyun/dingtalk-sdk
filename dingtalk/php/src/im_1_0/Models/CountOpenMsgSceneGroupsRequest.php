<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CountOpenMsgSceneGroupsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example f6xxxxx
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'templateId' => 'templateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CountOpenMsgSceneGroupsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
