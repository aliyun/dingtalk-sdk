<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateReviewChecklistResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateReviewChecklistResponseBody\data\checklist\rules;
use AlibabaCloud\Tea\Model;

class checklist extends Model
{
    /**
     * @var string
     */
    public $createdAt;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $name;

    /**
     * @var rules[]
     */
    public $rules;

    /**
     * @var string
     */
    public $updatedAt;

    /**
     * @var int
     */
    public $version;
    protected $_name = [
        'createdAt' => 'created_at',
        'id' => 'id',
        'name' => 'name',
        'rules' => 'rules',
        'updatedAt' => 'updated_at',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdAt) {
            $res['created_at'] = $this->createdAt;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->rules) {
            $res['rules'] = [];
            if (null !== $this->rules && \is_array($this->rules)) {
                $n = 0;
                foreach ($this->rules as $item) {
                    $res['rules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->updatedAt) {
            $res['updated_at'] = $this->updatedAt;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return checklist
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['rules'])) {
            if (!empty($map['rules'])) {
                $model->rules = [];
                $n = 0;
                foreach ($map['rules'] as $item) {
                    $model->rules[$n++] = null !== $item ? rules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['updated_at'])) {
            $model->updatedAt = $map['updated_at'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
