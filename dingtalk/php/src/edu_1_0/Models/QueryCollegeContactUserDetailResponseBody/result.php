<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\deptOrderList;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\deptPositionSet;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\deptTypeSet;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\leaderInDept;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\roleList;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result\unionEmpExt;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $active;

    /**
     * @var bool
     */
    public $admin;

    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $avatar;

    /**
     * @var bool
     */
    public $boss;

    /**
     * @var int[]
     */
    public $deptIdList;

    /**
     * @var deptOrderList[]
     */
    public $deptOrderList;

    /**
     * @var deptPositionSet[]
     */
    public $deptPositionSet;

    /**
     * @var deptTypeSet[]
     */
    public $deptTypeSet;

    /**
     * @example test@xxx.com
     *
     * @var string
     */
    public $email;

    /**
     * @example college_student
     *
     * @var string
     */
    public $empType;

    /**
     * @var bool
     */
    public $exclusiveAccount;

    /**
     * @var string
     */
    public $exclusiveAccountCorpId;

    /**
     * @example 组织名称
     *
     * @var string
     */
    public $exclusiveAccountCorpName;

    /**
     * @example dingtalk
     *
     * @var string
     */
    public $exclusiveAccountType;

    /**
     * @example {"学号":"12122294","在校状态":"新生","学生类别":"本科生","考生号":"999888"}
     *
     * @var string
     */
    public $extension;

    /**
     * @var bool
     */
    public $hideMobile;

    /**
     * @example 1597573616828
     *
     * @var int
     */
    public $hiredDate;

    /**
     * @example 12122294
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @var leaderInDept[]
     */
    public $leaderInDept;

    /**
     * @example 12122294
     *
     * @var string
     */
    public $loginId;

    /**
     * @example studentNo
     *
     * @var string
     */
    public $loginType;

    /**
     * @example 123456
     *
     * @var int
     */
    public $mainDeptId;

    /**
     * @example 111111
     *
     * @var string
     */
    public $managerUserid;

    /**
     * @example 188****4567
     *
     * @var string
     */
    public $mobile;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example test@xxx.com
     *
     * @var string
     */
    public $orgEmail;

    /**
     * @example profession
     *
     * @var string
     */
    public $orgEmailType;

    /**
     * @var bool
     */
    public $realAuthed;

    /**
     * @example 这是一个备注
     *
     * @var string
     */
    public $remark;

    /**
     * @var roleList[]
     */
    public $roleList;

    /**
     * @var bool
     */
    public $senior;

    /**
     * @example 86
     *
     * @var string
     */
    public $stateCode;

    /**
     * @example 010-86123456-2345
     *
     * @var string
     */
    public $telephone;

    /**
     * @example 学工处处长
     *
     * @var string
     */
    public $title;

    /**
     * @var unionEmpExt
     */
    public $unionEmpExt;

    /**
     * @example z21HjQliSzpw0YWCNxmii6u2Os62cZ62iSZ
     *
     * @var string
     */
    public $unionId;

    /**
     * @example zhangsan666
     *
     * @var string
     */
    public $userid;

    /**
     * @example 学工处办公室
     *
     * @var string
     */
    public $workPlace;
    protected $_name = [
        'active' => 'active',
        'admin' => 'admin',
        'avatar' => 'avatar',
        'boss' => 'boss',
        'deptIdList' => 'deptIdList',
        'deptOrderList' => 'deptOrderList',
        'deptPositionSet' => 'deptPositionSet',
        'deptTypeSet' => 'deptTypeSet',
        'email' => 'email',
        'empType' => 'empType',
        'exclusiveAccount' => 'exclusiveAccount',
        'exclusiveAccountCorpId' => 'exclusiveAccountCorpId',
        'exclusiveAccountCorpName' => 'exclusiveAccountCorpName',
        'exclusiveAccountType' => 'exclusiveAccountType',
        'extension' => 'extension',
        'hideMobile' => 'hideMobile',
        'hiredDate' => 'hiredDate',
        'jobNumber' => 'jobNumber',
        'leaderInDept' => 'leaderInDept',
        'loginId' => 'loginId',
        'loginType' => 'loginType',
        'mainDeptId' => 'mainDeptId',
        'managerUserid' => 'managerUserid',
        'mobile' => 'mobile',
        'name' => 'name',
        'orgEmail' => 'orgEmail',
        'orgEmailType' => 'orgEmailType',
        'realAuthed' => 'realAuthed',
        'remark' => 'remark',
        'roleList' => 'roleList',
        'senior' => 'senior',
        'stateCode' => 'stateCode',
        'telephone' => 'telephone',
        'title' => 'title',
        'unionEmpExt' => 'unionEmpExt',
        'unionId' => 'unionId',
        'userid' => 'userid',
        'workPlace' => 'workPlace',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->admin) {
            $res['admin'] = $this->admin;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->boss) {
            $res['boss'] = $this->boss;
        }
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->deptOrderList) {
            $res['deptOrderList'] = [];
            if (null !== $this->deptOrderList && \is_array($this->deptOrderList)) {
                $n = 0;
                foreach ($this->deptOrderList as $item) {
                    $res['deptOrderList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deptPositionSet) {
            $res['deptPositionSet'] = [];
            if (null !== $this->deptPositionSet && \is_array($this->deptPositionSet)) {
                $n = 0;
                foreach ($this->deptPositionSet as $item) {
                    $res['deptPositionSet'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deptTypeSet) {
            $res['deptTypeSet'] = [];
            if (null !== $this->deptTypeSet && \is_array($this->deptTypeSet)) {
                $n = 0;
                foreach ($this->deptTypeSet as $item) {
                    $res['deptTypeSet'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->empType) {
            $res['empType'] = $this->empType;
        }
        if (null !== $this->exclusiveAccount) {
            $res['exclusiveAccount'] = $this->exclusiveAccount;
        }
        if (null !== $this->exclusiveAccountCorpId) {
            $res['exclusiveAccountCorpId'] = $this->exclusiveAccountCorpId;
        }
        if (null !== $this->exclusiveAccountCorpName) {
            $res['exclusiveAccountCorpName'] = $this->exclusiveAccountCorpName;
        }
        if (null !== $this->exclusiveAccountType) {
            $res['exclusiveAccountType'] = $this->exclusiveAccountType;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hideMobile) {
            $res['hideMobile'] = $this->hideMobile;
        }
        if (null !== $this->hiredDate) {
            $res['hiredDate'] = $this->hiredDate;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
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
        if (null !== $this->loginId) {
            $res['loginId'] = $this->loginId;
        }
        if (null !== $this->loginType) {
            $res['loginType'] = $this->loginType;
        }
        if (null !== $this->mainDeptId) {
            $res['mainDeptId'] = $this->mainDeptId;
        }
        if (null !== $this->managerUserid) {
            $res['managerUserid'] = $this->managerUserid;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->orgEmail) {
            $res['orgEmail'] = $this->orgEmail;
        }
        if (null !== $this->orgEmailType) {
            $res['orgEmailType'] = $this->orgEmailType;
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
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
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
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        if (null !== $this->workPlace) {
            $res['workPlace'] = $this->workPlace;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
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
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['boss'])) {
            $model->boss = $map['boss'];
        }
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['deptOrderList'])) {
            if (!empty($map['deptOrderList'])) {
                $model->deptOrderList = [];
                $n = 0;
                foreach ($map['deptOrderList'] as $item) {
                    $model->deptOrderList[$n++] = null !== $item ? deptOrderList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deptPositionSet'])) {
            if (!empty($map['deptPositionSet'])) {
                $model->deptPositionSet = [];
                $n = 0;
                foreach ($map['deptPositionSet'] as $item) {
                    $model->deptPositionSet[$n++] = null !== $item ? deptPositionSet::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deptTypeSet'])) {
            if (!empty($map['deptTypeSet'])) {
                $model->deptTypeSet = [];
                $n = 0;
                foreach ($map['deptTypeSet'] as $item) {
                    $model->deptTypeSet[$n++] = null !== $item ? deptTypeSet::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['empType'])) {
            $model->empType = $map['empType'];
        }
        if (isset($map['exclusiveAccount'])) {
            $model->exclusiveAccount = $map['exclusiveAccount'];
        }
        if (isset($map['exclusiveAccountCorpId'])) {
            $model->exclusiveAccountCorpId = $map['exclusiveAccountCorpId'];
        }
        if (isset($map['exclusiveAccountCorpName'])) {
            $model->exclusiveAccountCorpName = $map['exclusiveAccountCorpName'];
        }
        if (isset($map['exclusiveAccountType'])) {
            $model->exclusiveAccountType = $map['exclusiveAccountType'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hideMobile'])) {
            $model->hideMobile = $map['hideMobile'];
        }
        if (isset($map['hiredDate'])) {
            $model->hiredDate = $map['hiredDate'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['leaderInDept'])) {
            if (!empty($map['leaderInDept'])) {
                $model->leaderInDept = [];
                $n = 0;
                foreach ($map['leaderInDept'] as $item) {
                    $model->leaderInDept[$n++] = null !== $item ? leaderInDept::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['loginId'])) {
            $model->loginId = $map['loginId'];
        }
        if (isset($map['loginType'])) {
            $model->loginType = $map['loginType'];
        }
        if (isset($map['mainDeptId'])) {
            $model->mainDeptId = $map['mainDeptId'];
        }
        if (isset($map['managerUserid'])) {
            $model->managerUserid = $map['managerUserid'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['orgEmail'])) {
            $model->orgEmail = $map['orgEmail'];
        }
        if (isset($map['orgEmailType'])) {
            $model->orgEmailType = $map['orgEmailType'];
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
                $n = 0;
                foreach ($map['roleList'] as $item) {
                    $model->roleList[$n++] = null !== $item ? roleList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['senior'])) {
            $model->senior = $map['senior'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
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
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }
        if (isset($map['workPlace'])) {
            $model->workPlace = $map['workPlace'];
        }

        return $model;
    }
}
