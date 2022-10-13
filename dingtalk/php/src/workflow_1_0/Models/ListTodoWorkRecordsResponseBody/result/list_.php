<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListTodoWorkRecordsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListTodoWorkRecordsResponseBody\result\list_\forms;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 表单列表。
     *
     * @var forms[]
     */
    public $forms;

    /**
     * @description 实例ID。
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 待办任务ID。
     *
     * @var int
     */
    public $taskId;

    /**
     * @description 待办标题。
     *
     * @var string
     */
    public $title;

    /**
     * @description 待办跳转链接。
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'forms'      => 'forms',
        'instanceId' => 'instanceId',
        'taskId'     => 'taskId',
        'title'      => 'title',
        'url'        => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->forms) {
            $res['forms'] = [];
            if (null !== $this->forms && \is_array($this->forms)) {
                $n = 0;
                foreach ($this->forms as $item) {
                    $res['forms'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['forms'])) {
            if (!empty($map['forms'])) {
                $model->forms = [];
                $n            = 0;
                foreach ($map['forms'] as $item) {
                    $model->forms[$n++] = null !== $item ? forms::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
