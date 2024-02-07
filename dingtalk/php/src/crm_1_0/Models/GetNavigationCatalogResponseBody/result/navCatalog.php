<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetNavigationCatalogResponseBody\result;

use AlibabaCloud\Tea\Model;

class navCatalog extends Model
{
    /**
     * @var mixed
     */
    public $children;

    /**
     * @var string
     */
    public $navCode;

    /**
     * @var string
     */
    public $navId;

    /**
     * @var string
     */
    public $navName;

    /**
     * @var string
     */
    public $navType;
    protected $_name = [
        'children' => 'children',
        'navCode'  => 'navCode',
        'navId'    => 'navId',
        'navName'  => 'navName',
        'navType'  => 'navType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->children) {
            $res['children'] = $this->children;
        }
        if (null !== $this->navCode) {
            $res['navCode'] = $this->navCode;
        }
        if (null !== $this->navId) {
            $res['navId'] = $this->navId;
        }
        if (null !== $this->navName) {
            $res['navName'] = $this->navName;
        }
        if (null !== $this->navType) {
            $res['navType'] = $this->navType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return navCatalog
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['children'])) {
            $model->children = $map['children'];
        }
        if (isset($map['navCode'])) {
            $model->navCode = $map['navCode'];
        }
        if (isset($map['navId'])) {
            $model->navId = $map['navId'];
        }
        if (isset($map['navName'])) {
            $model->navName = $map['navName'];
        }
        if (isset($map['navType'])) {
            $model->navType = $map['navType'];
        }

        return $model;
    }
}
