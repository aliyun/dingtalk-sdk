<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardWithDelegateRequest\imGroupOpenSpaceModel;

use AlibabaCloud\Tea\Model;

class searchSupport extends Model
{
    /**
     * @var string
     */
    public $searchDesc;

    /**
     * @example @lALPDgQ9q8hFhlHNAXzNAqI
     *
     * @var string
     */
    public $searchIcon;

    /**
     * @example {"zh_CN":"待办","zh_TW":"待辦","en_US":"ToDo"}
     *
     * @var string
     */
    public $searchTypeName;
    protected $_name = [
        'searchDesc' => 'searchDesc',
        'searchIcon' => 'searchIcon',
        'searchTypeName' => 'searchTypeName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->searchDesc) {
            $res['searchDesc'] = $this->searchDesc;
        }
        if (null !== $this->searchIcon) {
            $res['searchIcon'] = $this->searchIcon;
        }
        if (null !== $this->searchTypeName) {
            $res['searchTypeName'] = $this->searchTypeName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return searchSupport
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['searchDesc'])) {
            $model->searchDesc = $map['searchDesc'];
        }
        if (isset($map['searchIcon'])) {
            $model->searchIcon = $map['searchIcon'];
        }
        if (isset($map['searchTypeName'])) {
            $model->searchTypeName = $map['searchTypeName'];
        }

        return $model;
    }
}
