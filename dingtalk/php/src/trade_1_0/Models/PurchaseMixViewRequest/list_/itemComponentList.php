<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest\list_;

use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest\list_\itemComponentList\itemPropertyList;
use AlibabaCloud\Tea\Model;

class itemComponentList extends Model
{
    /**
     * @var string
     */
    public $componentCode;

    /**
     * @var string
     */
    public $componentName;

    /**
     * @var itemPropertyList[]
     */
    public $itemPropertyList;
    protected $_name = [
        'componentCode' => 'componentCode',
        'componentName' => 'componentName',
        'itemPropertyList' => 'itemPropertyList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentCode) {
            $res['componentCode'] = $this->componentCode;
        }
        if (null !== $this->componentName) {
            $res['componentName'] = $this->componentName;
        }
        if (null !== $this->itemPropertyList) {
            $res['itemPropertyList'] = [];
            if (null !== $this->itemPropertyList && \is_array($this->itemPropertyList)) {
                $n = 0;
                foreach ($this->itemPropertyList as $item) {
                    $res['itemPropertyList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return itemComponentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentCode'])) {
            $model->componentCode = $map['componentCode'];
        }
        if (isset($map['componentName'])) {
            $model->componentName = $map['componentName'];
        }
        if (isset($map['itemPropertyList'])) {
            if (!empty($map['itemPropertyList'])) {
                $model->itemPropertyList = [];
                $n = 0;
                foreach ($map['itemPropertyList'] as $item) {
                    $model->itemPropertyList[$n++] = null !== $item ? itemPropertyList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
