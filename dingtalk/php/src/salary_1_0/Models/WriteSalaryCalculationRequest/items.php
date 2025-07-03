<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationRequest;

use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationRequest\items\contents;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var contents[]
     */
    public $contents;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'contents' => 'contents',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contents) {
            $res['contents'] = [];
            if (null !== $this->contents && \is_array($this->contents)) {
                $n = 0;
                foreach ($this->contents as $item) {
                    $res['contents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contents'])) {
            if (!empty($map['contents'])) {
                $model->contents = [];
                $n = 0;
                foreach ($map['contents'] as $item) {
                    $model->contents[$n++] = null !== $item ? contents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
