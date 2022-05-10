<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListJoinOrgInfoResponseBody;

use AlibabaCloud\Tea\Model;

class orgInfoList extends Model
{
    /**
     * @description 组织ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 组织代码
     *
     * @var string
     */
    public $domain;

    /**
     * @description 组织全称
     *
     * @var string
     */
    public $orgFullName;

    /**
     * @description 组织名称
     *
     * @var int
     */
    public $orgName;
    protected $_name = [
        'corpId'      => 'corpId',
        'domain'      => 'domain',
        'orgFullName' => 'orgFullName',
        'orgName'     => 'orgName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->domain) {
            $res['domain'] = $this->domain;
        }
        if (null !== $this->orgFullName) {
            $res['orgFullName'] = $this->orgFullName;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['domain'])) {
            $model->domain = $map['domain'];
        }
        if (isset($map['orgFullName'])) {
            $model->orgFullName = $map['orgFullName'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }

        return $model;
    }
}
