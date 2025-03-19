<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByAttrRequest\listDynamicAttr;
use AlibabaCloud\Tea\Model;

class GroupQueryByAttrRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $groupTopic;

    /**
     * @var string
     */
    public $groupType;

    /**
     * @var listDynamicAttr[]
     */
    public $listDynamicAttr;

    /**
     * @var int
     */
    public $pageIndex;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $secretKey;
    protected $_name = [
        'corpId' => 'corpId',
        'groupTopic' => 'groupTopic',
        'groupType' => 'groupType',
        'listDynamicAttr' => 'listDynamicAttr',
        'pageIndex' => 'pageIndex',
        'pageSize' => 'pageSize',
        'secretKey' => 'secretKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupTopic) {
            $res['groupTopic'] = $this->groupTopic;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->listDynamicAttr) {
            $res['listDynamicAttr'] = [];
            if (null !== $this->listDynamicAttr && \is_array($this->listDynamicAttr)) {
                $n = 0;
                foreach ($this->listDynamicAttr as $item) {
                    $res['listDynamicAttr'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pageIndex) {
            $res['pageIndex'] = $this->pageIndex;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupQueryByAttrRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupTopic'])) {
            $model->groupTopic = $map['groupTopic'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['listDynamicAttr'])) {
            if (!empty($map['listDynamicAttr'])) {
                $model->listDynamicAttr = [];
                $n = 0;
                foreach ($map['listDynamicAttr'] as $item) {
                    $model->listDynamicAttr[$n++] = null !== $item ? listDynamicAttr::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pageIndex'])) {
            $model->pageIndex = $map['pageIndex'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }

        return $model;
    }
}
