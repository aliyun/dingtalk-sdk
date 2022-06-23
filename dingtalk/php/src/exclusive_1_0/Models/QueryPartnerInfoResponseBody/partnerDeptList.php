<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponseBody\partnerDeptList\partnerLabelModelLevel1;
use AlibabaCloud\Tea\Model;

class partnerDeptList extends Model
{
    /**
     * @description 部门人数
     *
     * @var int
     */
    public $memberCount;

    /**
     * @description 一级伙伴类型
     *
     * @var partnerLabelModelLevel1[]
     */
    public $partnerLabelModelLevel1;

    /**
     * @description 伙伴编码
     *
     * @var string
     */
    public $partnerNum;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 部门id
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'memberCount'             => 'memberCount',
        'partnerLabelModelLevel1' => 'partnerLabelModelLevel1',
        'partnerNum'              => 'partnerNum',
        'title'                   => 'title',
        'value'                   => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }
        if (null !== $this->partnerLabelModelLevel1) {
            $res['partnerLabelModelLevel1'] = [];
            if (null !== $this->partnerLabelModelLevel1 && \is_array($this->partnerLabelModelLevel1)) {
                $n = 0;
                foreach ($this->partnerLabelModelLevel1 as $item) {
                    $res['partnerLabelModelLevel1'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->partnerNum) {
            $res['partnerNum'] = $this->partnerNum;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return partnerDeptList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }
        if (isset($map['partnerLabelModelLevel1'])) {
            if (!empty($map['partnerLabelModelLevel1'])) {
                $model->partnerLabelModelLevel1 = [];
                $n                              = 0;
                foreach ($map['partnerLabelModelLevel1'] as $item) {
                    $model->partnerLabelModelLevel1[$n++] = null !== $item ? partnerLabelModelLevel1::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['partnerNum'])) {
            $model->partnerNum = $map['partnerNum'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
