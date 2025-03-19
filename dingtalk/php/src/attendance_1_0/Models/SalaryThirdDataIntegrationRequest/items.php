<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SalaryThirdDataIntegrationRequest;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SalaryThirdDataIntegrationRequest\items\bizContents;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var bizContents[]
     */
    public $bizContents;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizDate;

    /**
     * @description This parameter is required.
     *
     * @example 100001
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizContents' => 'bizContents',
        'bizDate' => 'bizDate',
        'bizId' => 'bizId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizContents) {
            $res['bizContents'] = [];
            if (null !== $this->bizContents && \is_array($this->bizContents)) {
                $n = 0;
                foreach ($this->bizContents as $item) {
                    $res['bizContents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizDate) {
            $res['bizDate'] = $this->bizDate;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizContents'])) {
            if (!empty($map['bizContents'])) {
                $model->bizContents = [];
                $n = 0;
                foreach ($map['bizContents'] as $item) {
                    $model->bizContents[$n++] = null !== $item ? bizContents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizDate'])) {
            $model->bizDate = $map['bizDate'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
