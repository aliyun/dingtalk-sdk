<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\JoinGroupSetRequest\bizDataList;
use AlibabaCloud\Tea\Model;

class JoinGroupSetRequest extends Model
{
    /**
     * @description 关系模型数据。
     *
     * @var bizDataList[]
     */
    public $bizDataList;

    /**
     * @description 组织id。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 群组openGroupSetId。
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description unionId。
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizDataList'    => 'bizDataList',
        'corpId'         => 'corpId',
        'openGroupSetId' => 'openGroupSetId',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizDataList) {
            $res['bizDataList'] = [];
            if (null !== $this->bizDataList && \is_array($this->bizDataList)) {
                $n = 0;
                foreach ($this->bizDataList as $item) {
                    $res['bizDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return JoinGroupSetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizDataList'])) {
            if (!empty($map['bizDataList'])) {
                $model->bizDataList = [];
                $n                  = 0;
                foreach ($map['bizDataList'] as $item) {
                    $model->bizDataList[$n++] = null !== $item ? bizDataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
