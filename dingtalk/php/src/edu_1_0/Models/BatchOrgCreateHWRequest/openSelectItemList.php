<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest\openSelectItemList\classList;
use AlibabaCloud\Tea\Model;

class openSelectItemList extends Model
{
    /**
     * @description 班级列表
     *
     * @var classList[]
     */
    public $classList;

    /**
     * @description 组织corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 选择内容
     *
     * @var string
     */
    public $selectedClassesDesc;
    protected $_name = [
        'classList'           => 'classList',
        'corpId'              => 'corpId',
        'selectedClassesDesc' => 'selectedClassesDesc',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classList) {
            $res['classList'] = [];
            if (null !== $this->classList && \is_array($this->classList)) {
                $n = 0;
                foreach ($this->classList as $item) {
                    $res['classList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->selectedClassesDesc) {
            $res['selectedClassesDesc'] = $this->selectedClassesDesc;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openSelectItemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classList'])) {
            if (!empty($map['classList'])) {
                $model->classList = [];
                $n                = 0;
                foreach ($map['classList'] as $item) {
                    $model->classList[$n++] = null !== $item ? classList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['selectedClassesDesc'])) {
            $model->selectedClassesDesc = $map['selectedClassesDesc'];
        }

        return $model;
    }
}
