<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCategoryNameRequest extends Model
{
    /**
     * @example demo
     *
     * @var string
     */
    public $currentCategoryName;

    /**
     * @example demo01
     *
     * @var string
     */
    public $targetCategoryName;
    protected $_name = [
        'currentCategoryName' => 'currentCategoryName',
        'targetCategoryName'  => 'targetCategoryName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentCategoryName) {
            $res['currentCategoryName'] = $this->currentCategoryName;
        }
        if (null !== $this->targetCategoryName) {
            $res['targetCategoryName'] = $this->targetCategoryName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCategoryNameRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['currentCategoryName'])) {
            $model->currentCategoryName = $map['currentCategoryName'];
        }
        if (isset($map['targetCategoryName'])) {
            $model->targetCategoryName = $map['targetCategoryName'];
        }

        return $model;
    }
}
