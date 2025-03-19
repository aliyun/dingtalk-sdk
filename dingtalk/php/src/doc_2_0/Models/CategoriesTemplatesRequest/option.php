<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoriesTemplatesRequest;

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
     * @example pc
     *
     * @var string
     */
    public $queryPlatform;

    /**
     * @example 1
     *
     * @var int
     */
    public $size;

    /**
     * @example 1
     *
     * @var int
     */
    public $templateStatus;
    protected $_name = [
        'categoryStatus' => 'categoryStatus',
        'queryPlatform' => 'queryPlatform',
        'size' => 'size',
        'templateStatus' => 'templateStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryStatus) {
            $res['categoryStatus'] = $this->categoryStatus;
        }
        if (null !== $this->queryPlatform) {
            $res['queryPlatform'] = $this->queryPlatform;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
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
        if (isset($map['queryPlatform'])) {
            $model->queryPlatform = $map['queryPlatform'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['templateStatus'])) {
            $model->templateStatus = $map['templateStatus'];
        }

        return $model;
    }
}
