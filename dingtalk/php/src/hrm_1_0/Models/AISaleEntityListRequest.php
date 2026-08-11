<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityListRequest\conditions;
use AlibabaCloud\Tea\Model;

class AISaleEntityListRequest extends Model
{
    /**
     * @var conditions[]
     */
    public $conditions;

    /**
     * @example 123
     *
     * @var string
     */
    public $cursor;

    /**
     * @example CUSTOMER
     *
     * @var string
     */
    public $entityType;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @example userId123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'conditions' => 'conditions',
        'cursor' => 'cursor',
        'entityType' => 'entityType',
        'pageSize' => 'pageSize',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conditions) {
            $res['conditions'] = [];
            if (null !== $this->conditions && \is_array($this->conditions)) {
                $n = 0;
                foreach ($this->conditions as $item) {
                    $res['conditions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AISaleEntityListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conditions'])) {
            if (!empty($map['conditions'])) {
                $model->conditions = [];
                $n = 0;
                foreach ($map['conditions'] as $item) {
                    $model->conditions[$n++] = null !== $item ? conditions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
