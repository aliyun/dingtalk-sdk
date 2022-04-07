<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoResponseBody\content;
use AlibabaCloud\Tea\Model;

class CustomizeContactDeptInfoResponseBody extends Model
{
    /**
     * @description 部门信息
     *
     * @var content
     */
    public $content;
    protected $_name = [
        'content' => 'content',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactDeptInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }

        return $model;
    }
}
