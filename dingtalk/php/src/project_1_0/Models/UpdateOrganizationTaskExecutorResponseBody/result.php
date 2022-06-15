<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskExecutorResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskExecutorResponseBody\result\executor;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskExecutorResponseBody\result\involvers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 执行者信息
     *
     * @var executor
     */
    public $executor;

    /**
     * @description 执行者id
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 参与者列表
     *
     * @var involvers[]
     */
    public $involvers;

    /**
     * @description 更新时间
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'executor'   => 'executor',
        'executorId' => 'executorId',
        'involvers'  => 'involvers',
        'updated'    => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->executor) {
            $res['executor'] = null !== $this->executor ? $this->executor->toMap() : null;
        }
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->involvers) {
            $res['involvers'] = [];
            if (null !== $this->involvers && \is_array($this->involvers)) {
                $n = 0;
                foreach ($this->involvers as $item) {
                    $res['involvers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['executor'])) {
            $model->executor = executor::fromMap($map['executor']);
        }
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['involvers'])) {
            if (!empty($map['involvers'])) {
                $model->involvers = [];
                $n                = 0;
                foreach ($map['involvers'] as $item) {
                    $model->involvers[$n++] = null !== $item ? involvers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
