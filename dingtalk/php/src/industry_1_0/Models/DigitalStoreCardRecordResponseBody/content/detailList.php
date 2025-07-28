<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreCardRecordResponseBody\content;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $readStatusStr;

    /**
     * @var int
     */
    public $readTime;

    /**
     * @var string
     */
    public $roleName;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'deptName' => 'deptName',
        'readStatusStr' => 'readStatusStr',
        'readTime' => 'readTime',
        'roleName' => 'roleName',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->readStatusStr) {
            $res['readStatusStr'] = $this->readStatusStr;
        }
        if (null !== $this->readTime) {
            $res['readTime'] = $this->readTime;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['readStatusStr'])) {
            $model->readStatusStr = $map['readStatusStr'];
        }
        if (isset($map['readTime'])) {
            $model->readTime = $map['readTime'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
