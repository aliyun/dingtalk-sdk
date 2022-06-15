<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 状态：0-有效，1-无效
     *
     * @var int
     */
    public $status;

    /**
     * @description 用户标识
     *
     * @var string
     */
    public $userCode;

    /**
     * @description 扩展属性描述
     *
     * @var string
     */
    public $userExtendDisplayName;

    /**
     * @description 扩展属性Key
     *
     * @var string
     */
    public $userExtendKey;

    /**
     * @description 扩展属性值
     *
     * @var string
     */
    public $userExtendValue;
    protected $_name = [
        'gmtCreate'             => 'gmtCreate',
        'gmtModified'           => 'gmtModified',
        'status'                => 'status',
        'userCode'              => 'userCode',
        'userExtendDisplayName' => 'userExtendDisplayName',
        'userExtendKey'         => 'userExtendKey',
        'userExtendValue'       => 'userExtendValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userCode) {
            $res['userCode'] = $this->userCode;
        }
        if (null !== $this->userExtendDisplayName) {
            $res['userExtendDisplayName'] = $this->userExtendDisplayName;
        }
        if (null !== $this->userExtendKey) {
            $res['userExtendKey'] = $this->userExtendKey;
        }
        if (null !== $this->userExtendValue) {
            $res['userExtendValue'] = $this->userExtendValue;
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
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userCode'])) {
            $model->userCode = $map['userCode'];
        }
        if (isset($map['userExtendDisplayName'])) {
            $model->userExtendDisplayName = $map['userExtendDisplayName'];
        }
        if (isset($map['userExtendKey'])) {
            $model->userExtendKey = $map['userExtendKey'];
        }
        if (isset($map['userExtendValue'])) {
            $model->userExtendValue = $map['userExtendValue'];
        }

        return $model;
    }
}
