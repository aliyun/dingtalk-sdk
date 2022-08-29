<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskRequest;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @description 待办事项跳转URL。
     * 创建审批实例接口里的url，实现的是钉钉审批应用里的审批单跳转。这个接口里的url，实现的是钉钉待办页面，对应的待办卡片的跳转。两种跳转场景不同。需要注意的是，钉钉的待办页面，也同时支持移动端和PC端，所以这个接口里传的url参数，它所对应的页面也要适配好移动端和PC端。
     *
     * @var string
     */
    public $url;

    /**
     * @description OA审批任务执行人的用户ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'url'    => 'url',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
