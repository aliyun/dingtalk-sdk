<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\config;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\courseDTOS;
use AlibabaCloud\Tea\Model;

class QueryClassScheduleResponseBody extends Model
{
    /**
     * @description 课表时间节次配置。
     *
     * @var config
     */
    public $config;

    /**
     * @description 课程列表
     *
     * @var courseDTOS[]
     */
    public $courseDTOS;
    protected $_name = [
        'config'     => 'config',
        'courseDTOS' => 'courseDTOS',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->config) {
            $res['config'] = null !== $this->config ? $this->config->toMap() : null;
        }
        if (null !== $this->courseDTOS) {
            $res['courseDTOS'] = [];
            if (null !== $this->courseDTOS && \is_array($this->courseDTOS)) {
                $n = 0;
                foreach ($this->courseDTOS as $item) {
                    $res['courseDTOS'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryClassScheduleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['config'])) {
            $model->config = config::fromMap($map['config']);
        }
        if (isset($map['courseDTOS'])) {
            if (!empty($map['courseDTOS'])) {
                $model->courseDTOS = [];
                $n                 = 0;
                foreach ($map['courseDTOS'] as $item) {
                    $model->courseDTOS[$n++] = null !== $item ? courseDTOS::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
