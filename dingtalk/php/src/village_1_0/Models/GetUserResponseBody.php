<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\departmentOrderSet;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\leaderInDepartment;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\roleList;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\unionEmpExt;
use AlibabaCloud\Tea\Model;

class GetUserResponseBody extends Model
{
    /**
     * @description 是否激活
     *
     * @var bool
     */
    public $active;

    /**
     * @description 是否管理员
     *
     * @var bool
     */
    public $admin;

    /**
     * @description 是否老板
     *
     * @var bool
     */
    public $boss;

    /**
     * @description 所属部门id列表
     *
     * @var int[]
     */
    public $departmentIdList;

    /**
     * @description 员工在对应的部门中的排序。
     *
     * @var departmentOrderSet[]
     */
    public $departmentOrderSet;

    /**
     * @description 是否专属帐号
     *
     * @var bool
     */
    public $exclusiveAccount;

    /**
     * @description 专属帐号类型：{sso: 企业自定义idp;dingtalk: 钉钉idp}
     *
     * @var string
     */
    public $exclusiveAccountType;

    /**
     * @description 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
     *
     * @var string
     */
    public $extension;

    /**
     * @description 入职时间，Unix时间戳，单位ms。
     *
     * @var int
     */
    public $hiredDate;

    /**
     * @description 员工工号
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description 员工在对应的部门中是否领导。
     *
     * @var leaderInDepartment[]
     */
    public $leaderInDepartment;

    /**
     * @description 主管的ID，仅限企业内部开发调用
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 是否实名认证
     *
     * @var bool
     */
    public $realAuthed;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 角色列表
     *
     * @var roleList[]
     */
    public $roleList;

    /**
     * @description 是否高管
     *
     * @var bool
     */
    public $senior;

    /**
     * @description 职位
     *
     * @var string
     */
    public $title;

    /**
     * @description 关联信息
     *
     * @var unionEmpExt
     */
    public $unionEmpExt;

    /**
     * @description 员工在当前开发者企业账号范围内的唯一标识
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 办公地点
     *
     * @var string
     */
    public $workPlace;
    protected $_name = [
        'active'               => 'active',
        'admin'                => 'admin',
        'boss'                 => 'boss',
        'departmentIdList'     => 'departmentIdList',
        'departmentOrderSet'   => 'departmentOrderSet',
        'exclusiveAccount'     => 'exclusiveAccount',
        'exclusiveAccountType' => 'exclusiveAccountType',
        'extension'            => 'extension',
        'hiredDate'            => 'hiredDate',
        'jobNumber'            => 'jobNumber',
        'leaderInDepartment'   => 'leaderInDepartment',
        'managerUserId'        => 'managerUserId',
        'name'                 => 'name',
        'realAuthed'           => 'realAuthed',
        'remark'               => 'remark',
        'roleList'             => 'roleList',
        'senior'               => 'senior',
        'title'                => 'title',
        'unionEmpExt'          => 'unionEmpExt',
        'unionId'              => 'unionId',
        'userId'               => 'userId',
        'workPlace'            => 'workPlace',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->admin) {
            $res['admin'] = $this->admin;
        }
        if (null !== $this->boss) {
            $res['boss'] = $this->boss;
        }
        if (null !== $this->departmentIdList) {
            $res['departmentIdList'] = $this->departmentIdList;
        }
        if (null !== $this->departmentOrderSet) {
            $res['departmentOrderSet'] = [];
            if (null !== $this->departmentOrderSet && \is_array($this->departmentOrderSet)) {
                $n = 0;
                foreach ($this->departmentOrderSet as $item) {
                    $res['departmentOrderSet'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->exclusiveAccount) {
            $res['exclusiveAccount'] = $this->exclusiveAccount;
        }
        if (null !== $this->exclusiveAccountType) {
            $res['exclusiveAccountType'] = $this->exclusiveAccountType;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hiredDate) {
            $res['hiredDate'] = $this->hiredDate;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->leaderInDepartment) {
            $res['leaderInDepartment'] = [];
            if (null !== $this->leaderInDepartment && \is_array($this->leaderInDepartment)) {
                $n = 0;
                foreach ($this->leaderInDepartment as $item) {
                    $res['leaderInDepartment'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->realAuthed) {
            $res['realAuthed'] = $this->realAuthed;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->roleList) {
            $res['roleList'] = [];
            if (null !== $this->roleList && \is_array($this->roleList)) {
                $n = 0;
                foreach ($this->roleList as $item) {
                    $res['roleList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->senior) {
            $res['senior'] = $this->senior;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unionEmpExt) {
            $res['unionEmpExt'] = null !== $this->unionEmpExt ? $this->unionEmpExt->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->workPlace) {
            $res['workPlace'] = $this->workPlace;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['admin'])) {
            $model->admin = $map['admin'];
        }
        if (isset($map['boss'])) {
            $model->boss = $map['boss'];
        }
        if (isset($map['departmentIdList'])) {
            if (!empty($map['departmentIdList'])) {
                $model->departmentIdList = $map['departmentIdList'];
            }
        }
        if (isset($map['departmentOrderSet'])) {
            if (!empty($map['departmentOrderSet'])) {
                $model->departmentOrderSet = [];
                $n                         = 0;
                foreach ($map['departmentOrderSet'] as $item) {
                    $model->departmentOrderSet[$n++] = null !== $item ? departmentOrderSet::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['exclusiveAccount'])) {
            $model->exclusiveAccount = $map['exclusiveAccount'];
        }
        if (isset($map['exclusiveAccountType'])) {
            $model->exclusiveAccountType = $map['exclusiveAccountType'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hiredDate'])) {
            $model->hiredDate = $map['hiredDate'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['leaderInDepartment'])) {
            if (!empty($map['leaderInDepartment'])) {
                $model->leaderInDepartment = [];
                $n                         = 0;
                foreach ($map['leaderInDepartment'] as $item) {
                    $model->leaderInDepartment[$n++] = null !== $item ? leaderInDepartment::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['realAuthed'])) {
            $model->realAuthed = $map['realAuthed'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['roleList'])) {
            if (!empty($map['roleList'])) {
                $model->roleList = [];
                $n               = 0;
                foreach ($map['roleList'] as $item) {
                    $model->roleList[$n++] = null !== $item ? roleList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['senior'])) {
            $model->senior = $map['senior'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unionEmpExt'])) {
            $model->unionEmpExt = unionEmpExt::fromMap($map['unionEmpExt']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['workPlace'])) {
            $model->workPlace = $map['workPlace'];
        }

        return $model;
    }
}
