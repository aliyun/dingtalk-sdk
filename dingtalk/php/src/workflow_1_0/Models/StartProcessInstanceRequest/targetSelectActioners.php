<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest;

use AlibabaCloud\Tea\Model;

class targetSelectActioners extends Model
{
    /**
     * @example manual_1918_5cd3_5e19_6a98
     *
     * @var string
     */
    public $actionerKey;

    /**
     * @var string[]
     */
    public $actionerUserIds;
    protected $_name = [
        'actionerKey' => 'actionerKey',
        'actionerUserIds' => 'actionerUserIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionerKey) {
            $res['actionerKey'] = $this->actionerKey;
        }
        if (null !== $this->actionerUserIds) {
            $res['actionerUserIds'] = $this->actionerUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return targetSelectActioners
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionerKey'])) {
            $model->actionerKey = $map['actionerKey'];
        }
        if (isset($map['actionerUserIds'])) {
            if (!empty($map['actionerUserIds'])) {
                $model->actionerUserIds = $map['actionerUserIds'];
            }
        }

        return $model;
    }
}
