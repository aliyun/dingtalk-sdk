<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoResponseBody\content;
use AlibabaCloud\Tea\Model;

class GetEmployeeInfoByWorkNoResponseBody extends Model
{
    /**
     * @description 请求返回数据对象
     *
     * @var content
     */
    public $content;

    /**
     * @description 接口请求成功标识,成功为true,失败为false
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'content' => 'content',
        'success' => 'success',
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
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEmployeeInfoByWorkNoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
