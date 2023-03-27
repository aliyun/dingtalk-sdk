<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskExecutorResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 执行者用户ID。
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'executorId' => 'executorId',
        'updated'    => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
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
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
