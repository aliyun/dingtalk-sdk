<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoryTemplatesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $categoryStatus;

    /**
     * @example 1
     *
     * @var int
     */
    public $templateStatus;
    protected $_name = [
        'categoryStatus' => 'categoryStatus',
        'templateStatus' => 'templateStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryStatus) {
            $res['categoryStatus'] = $this->categoryStatus;
        }
        if (null !== $this->templateStatus) {
            $res['templateStatus'] = $this->templateStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryStatus'])) {
            $model->categoryStatus = $map['categoryStatus'];
        }
        if (isset($map['templateStatus'])) {
            $model->templateStatus = $map['templateStatus'];
        }

        return $model;
    }
}
