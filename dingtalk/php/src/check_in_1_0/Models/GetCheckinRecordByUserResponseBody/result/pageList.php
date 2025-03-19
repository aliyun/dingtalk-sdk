<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0\Models\GetCheckinRecordByUserResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0\Models\GetCheckinRecordByUserResponseBody\result\pageList\customDataList;
use AlibabaCloud\Tea\Model;

class pageList extends Model
{
    /**
     * @var int
     */
    public $checkinTime;

    /**
     * @var customDataList[]
     */
    public $customDataList;

    /**
     * @var string
     */
    public $detailPlace;

    /**
     * @var string[]
     */
    public $imageList;

    /**
     * @var string
     */
    public $place;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $visitUser;
    protected $_name = [
        'checkinTime' => 'checkinTime',
        'customDataList' => 'customDataList',
        'detailPlace' => 'detailPlace',
        'imageList' => 'imageList',
        'place' => 'place',
        'remark' => 'remark',
        'userId' => 'userId',
        'visitUser' => 'visitUser',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkinTime) {
            $res['checkinTime'] = $this->checkinTime;
        }
        if (null !== $this->customDataList) {
            $res['customDataList'] = [];
            if (null !== $this->customDataList && \is_array($this->customDataList)) {
                $n = 0;
                foreach ($this->customDataList as $item) {
                    $res['customDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->detailPlace) {
            $res['detailPlace'] = $this->detailPlace;
        }
        if (null !== $this->imageList) {
            $res['imageList'] = $this->imageList;
        }
        if (null !== $this->place) {
            $res['place'] = $this->place;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->visitUser) {
            $res['visitUser'] = $this->visitUser;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pageList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkinTime'])) {
            $model->checkinTime = $map['checkinTime'];
        }
        if (isset($map['customDataList'])) {
            if (!empty($map['customDataList'])) {
                $model->customDataList = [];
                $n = 0;
                foreach ($map['customDataList'] as $item) {
                    $model->customDataList[$n++] = null !== $item ? customDataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['detailPlace'])) {
            $model->detailPlace = $map['detailPlace'];
        }
        if (isset($map['imageList'])) {
            if (!empty($map['imageList'])) {
                $model->imageList = $map['imageList'];
            }
        }
        if (isset($map['place'])) {
            $model->place = $map['place'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['visitUser'])) {
            $model->visitUser = $map['visitUser'];
        }

        return $model;
    }
}
