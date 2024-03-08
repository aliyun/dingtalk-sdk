<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest\dataList\contactList;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest\dataList\enterprise;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest\dataList\tagIdList;
use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @var contactList[]
     */
    public $contactList;

    /**
     * @var enterprise
     */
    public $enterprise;

    /**
     * @example 钉钉中国
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @example demo
     *
     * @var string
     */
    public $sourceType;

    /**
     * @var tagIdList[]
     */
    public $tagIdList;
    protected $_name = [
        'contactList' => 'contactList',
        'enterprise'  => 'enterprise',
        'name'        => 'name',
        'sourceId'    => 'sourceId',
        'sourceType'  => 'sourceType',
        'tagIdList'   => 'tagIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactList) {
            $res['contactList'] = [];
            if (null !== $this->contactList && \is_array($this->contactList)) {
                $n = 0;
                foreach ($this->contactList as $item) {
                    $res['contactList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->enterprise) {
            $res['enterprise'] = null !== $this->enterprise ? $this->enterprise->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->tagIdList) {
            $res['tagIdList'] = [];
            if (null !== $this->tagIdList && \is_array($this->tagIdList)) {
                $n = 0;
                foreach ($this->tagIdList as $item) {
                    $res['tagIdList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactList'])) {
            if (!empty($map['contactList'])) {
                $model->contactList = [];
                $n                  = 0;
                foreach ($map['contactList'] as $item) {
                    $model->contactList[$n++] = null !== $item ? contactList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['enterprise'])) {
            $model->enterprise = enterprise::fromMap($map['enterprise']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['tagIdList'])) {
            if (!empty($map['tagIdList'])) {
                $model->tagIdList = [];
                $n                = 0;
                foreach ($map['tagIdList'] as $item) {
                    $model->tagIdList[$n++] = null !== $item ? tagIdList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
