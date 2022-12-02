<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content\deptList;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content\groupList;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content\jobStatus;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content\professionalTitle;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content\userProbList;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 科室列表
     *
     * @var deptList[]
     */
    public $deptList;

    /**
     * @description 医疗组列表
     *
     * @var groupList[]
     */
    public $groupList;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description 状态列表
     *
     * @var jobStatus[]
     */
    public $jobStatus;

    /**
     * @description 职称
     *
     * @var professionalTitle
     */
    public $professionalTitle;

    /**
     * @description 医生的userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $userName;

    /**
     * @description 身份属性
     *
     * @var userProbList[]
     */
    public $userProbList;
    protected $_name = [
        'deptList'          => 'deptList',
        'groupList'         => 'groupList',
        'jobNumber'         => 'jobNumber',
        'jobStatus'         => 'jobStatus',
        'professionalTitle' => 'professionalTitle',
        'userId'            => 'userId',
        'userName'          => 'userName',
        'userProbList'      => 'userProbList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptList) {
            $res['deptList'] = [];
            if (null !== $this->deptList && \is_array($this->deptList)) {
                $n = 0;
                foreach ($this->deptList as $item) {
                    $res['deptList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupList) {
            $res['groupList'] = [];
            if (null !== $this->groupList && \is_array($this->groupList)) {
                $n = 0;
                foreach ($this->groupList as $item) {
                    $res['groupList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->jobStatus) {
            $res['jobStatus'] = [];
            if (null !== $this->jobStatus && \is_array($this->jobStatus)) {
                $n = 0;
                foreach ($this->jobStatus as $item) {
                    $res['jobStatus'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->professionalTitle) {
            $res['professionalTitle'] = null !== $this->professionalTitle ? $this->professionalTitle->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->userProbList) {
            $res['userProbList'] = [];
            if (null !== $this->userProbList && \is_array($this->userProbList)) {
                $n = 0;
                foreach ($this->userProbList as $item) {
                    $res['userProbList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptList'])) {
            if (!empty($map['deptList'])) {
                $model->deptList = [];
                $n               = 0;
                foreach ($map['deptList'] as $item) {
                    $model->deptList[$n++] = null !== $item ? deptList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupList'])) {
            if (!empty($map['groupList'])) {
                $model->groupList = [];
                $n                = 0;
                foreach ($map['groupList'] as $item) {
                    $model->groupList[$n++] = null !== $item ? groupList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['jobStatus'])) {
            if (!empty($map['jobStatus'])) {
                $model->jobStatus = [];
                $n                = 0;
                foreach ($map['jobStatus'] as $item) {
                    $model->jobStatus[$n++] = null !== $item ? jobStatus::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['professionalTitle'])) {
            $model->professionalTitle = professionalTitle::fromMap($map['professionalTitle']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['userProbList'])) {
            if (!empty($map['userProbList'])) {
                $model->userProbList = [];
                $n                   = 0;
                foreach ($map['userProbList'] as $item) {
                    $model->userProbList[$n++] = null !== $item ? userProbList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
