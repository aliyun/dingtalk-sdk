<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetA1DetailPageCustomTabRequest\customTabList;
use AlibabaCloud\Tea\Model;

class SetA1DetailPageCustomTabRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var customTabList[]
     */
    public $customTabList;

    /**
     * @description true时保留已有A1分析Tab并替换其它自定义Tab；false或不传时直接使用本次列表覆盖
     *
     * @var bool
     */
    public $preserveA1AnalyzeTab;
    protected $_name = [
        'customTabList' => 'customTabList',
        'preserveA1AnalyzeTab' => 'preserveA1AnalyzeTab',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customTabList) {
            $res['customTabList'] = [];
            if (null !== $this->customTabList && \is_array($this->customTabList)) {
                $n = 0;
                foreach ($this->customTabList as $item) {
                    $res['customTabList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->preserveA1AnalyzeTab) {
            $res['preserveA1AnalyzeTab'] = $this->preserveA1AnalyzeTab;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetA1DetailPageCustomTabRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customTabList'])) {
            if (!empty($map['customTabList'])) {
                $model->customTabList = [];
                $n = 0;
                foreach ($map['customTabList'] as $item) {
                    $model->customTabList[$n++] = null !== $item ? customTabList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['preserveA1AnalyzeTab'])) {
            $model->preserveA1AnalyzeTab = $map['preserveA1AnalyzeTab'];
        }

        return $model;
    }
}
