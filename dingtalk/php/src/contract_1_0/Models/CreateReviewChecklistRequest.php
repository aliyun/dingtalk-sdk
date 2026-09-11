<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateReviewChecklistRequest\rules;
use AlibabaCloud\Tea\Model;

class CreateReviewChecklistRequest extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var rules[]
     */
    public $rules;
    protected $_name = [
        'corpId' => 'corp_id',
        'name' => 'name',
        'rules' => 'rules',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corp_id'] = $this->corpId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateReviewChecklistRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corp_id'])) {
            $model->corpId = $map['corp_id'];
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

        return $model;
    }
}
