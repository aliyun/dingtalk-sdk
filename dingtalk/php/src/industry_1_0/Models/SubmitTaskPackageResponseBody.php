<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitTaskPackageResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $taskIdList;

    /**
     * @var string
     */
    public $taskPackageId;
    protected $_name = [
        'taskIdList' => 'taskIdList',
        'taskPackageId' => 'taskPackageId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskIdList) {
            $res['taskIdList'] = $this->taskIdList;
        }
        if (null !== $this->taskPackageId) {
            $res['taskPackageId'] = $this->taskPackageId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitTaskPackageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskIdList'])) {
            if (!empty($map['taskIdList'])) {
                $model->taskIdList = $map['taskIdList'];
            }
        }
        if (isset($map['taskPackageId'])) {
            $model->taskPackageId = $map['taskPackageId'];
        }

        return $model;
    }
}
