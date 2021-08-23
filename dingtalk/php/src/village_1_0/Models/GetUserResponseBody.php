<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\deptOrderSet;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\leaderInDept;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\roleList;
use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\unionEmpExt;
use AlibabaCloud\Tea\Model;

class GetUserResponseBody extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 员工在当前开发者企业账号范围内的唯一标识
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 头像
     *
     * @var string
     */
    public $avatar;

    /**
     * @description 员工工号
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description 职位
     *
     * @var string
     */
    public $title;

    /**
     * @description 办公地点
     *
     * @var string
     */
    public $workPlace;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 所属部门id列表
     *
     * @var int[]
     */
    public $deptIdList;

    /**
     * @description 员工在对应的部门中的排序。
     *
     * @var deptOrderSet[]
     */
    public $deptOrderSet;

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
     * @description 是否激活
     *
     * @var bool
     */
    public $active;

    /**
     * @description 是否实名认证
     *
     * @var bool
     */
    public $realAuthed;

    /**
     * @description 是否高管
     *
     * @var bool
     */
    public $senior;

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
     * @description 员工在对应的部门中是否领导。
     *
     * @var leaderInDept[]
     */
    public $leaderInDept;

    /**
     * @description 角色列表
     *
     * @var roleList[]
     */
    public $roleList;

    /**
     * @description 关联信息
     *
     * @var unionEmpExt
     */
    public $unionEmpExt;

    /**
     * @description 主管的ID，仅限企业内部开发调用
     *
     * @var string
     */
    public $managerUserId;
    protected $_name = [
        'userId'               => 'userId',
        'unionId'              => 'unionId',
        'name'                 => 'name',
        'avatar'               => 'avatar',
        'jobNumber'            => 'jobNumber',
        'title'                => 'title',
        'workPlace'            => 'workPlace',
        'remark'               => 'remark',
        'deptIdList'           => 'deptIdList',
        'deptOrderSet'         => 'deptOrderSet',
        'extension'            => 'extension',
        'hiredDate'            => 'hiredDate',
        'active'               => 'active',
        'realAuthed'           => 'realAuthed',
        'senior'               => 'senior',
        'admin'                => 'admin',
        'boss'                 => 'boss',
        'exclusiveAccount'     => 'exclusiveAccount',
        'exclusiveAccountType' => 'exclusiveAccountType',
        'leaderInDept'         => 'leaderInDept',
        'roleList'             => 'roleList',
        'unionEmpExt'          => 'unionEmpExt',
        'managerUserId'        => 'managerUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->workPlace) {
            $res['workPlace'] = $this->workPlace;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->deptOrderSet) {
            $res['deptOrderSet'] = [];
            if (null !== $this->deptOrderSet && \is_array($this->deptOrderSet)) {
                $n = 0;
                foreach ($this->deptOrderSet as $item) {
                    $res['deptOrderSet'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hiredDate) {
            $res['hiredDate'] = $this->hiredDate;
        }
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->realAuthed) {
            $res['realAuthed'] = $this->realAuthed;
        }
        if (null !== $this->senior) {
            $res['senior'] = $this->senior;
        }
        if (null !== $this->admin) {
            $res['admin'] = $this->admin;
        }
        if (null !== $this->boss) {
            $res['boss'] = $this->boss;
        }
        if (null !== $this->exclusiveAccount) {
            $res['exclusiveAccount'] = $this->exclusiveAccount;
        }
        if (null !== $this->exclusiveAccountType) {
            $res['exclusiveAccountType'] = $this->exclusiveAccountType;
        }
        if (null !== $this->leaderInDept) {
            $res['leaderInDept'] = [];
            if (null !== $this->leaderInDept && \is_array($this->leaderInDept)) {
                $n = 0;
                foreach ($this->leaderInDept as $item) {
                    $res['leaderInDept'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->unionEmpExt) {
            $res['unionEmpExt'] = null !== $this->unionEmpExt ? $this->unionEmpExt->toMap() : null;
        }
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['workPlace'])) {
            $model->workPlace = $map['workPlace'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['deptOrderSet'])) {
            if (!empty($map['deptOrderSet'])) {
                $model->deptOrderSet = [];
                $n                   = 0;
                foreach ($map['deptOrderSet'] as $item) {
                    $model->deptOrderSet[$n++] = null !== $item ? deptOrderSet::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hiredDate'])) {
            $model->hiredDate = $map['hiredDate'];
        }
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['realAuthed'])) {
            $model->realAuthed = $map['realAuthed'];
        }
        if (isset($map['senior'])) {
            $model->senior = $map['senior'];
        }
        if (isset($map['admin'])) {
            $model->admin = $map['admin'];
        }
        if (isset($map['boss'])) {
            $model->boss = $map['boss'];
        }
        if (isset($map['exclusiveAccount'])) {
            $model->exclusiveAccount = $map['exclusiveAccount'];
        }
        if (isset($map['exclusiveAccountType'])) {
            $model->exclusiveAccountType = $map['exclusiveAccountType'];
        }
        if (isset($map['leaderInDept'])) {
            if (!empty($map['leaderInDept'])) {
                $model->leaderInDept = [];
                $n                   = 0;
                foreach ($map['leaderInDept'] as $item) {
                    $model->leaderInDept[$n++] = null !== $item ? leaderInDept::fromMap($item) : $item;
                }
            }
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
        if (isset($map['unionEmpExt'])) {
            $model->unionEmpExt = unionEmpExt::fromMap($map['unionEmpExt']);
        }
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }

        return $model;
    }
}
