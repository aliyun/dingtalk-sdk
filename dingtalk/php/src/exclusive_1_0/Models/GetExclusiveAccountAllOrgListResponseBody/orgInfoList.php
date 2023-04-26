<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetExclusiveAccountAllOrgListResponseBody;

use AlibabaCloud\Tea\Model;

class orgInfoList extends Model
{
    /**
     * @example ding32xxxxxxxxe0105d
     *
     * @var string
     */
    public $corpId;

    /**
     * @example true
     *
     * @var bool
     */
    public $isMainOrg;

    /**
     * @example http://xxx.dingtalk.com/xxx.jpg
     *
     * @var string
     */
    public $logoUrl;

    /**
     * @example 钉钉(中国)信息技术有限公司
     *
     * @var string
     */
    public $orgFullName;

    /**
     * @example 钉钉
     *
     * @var string
     */
    public $orgName;
    protected $_name = [
        'corpId'      => 'corpId',
        'isMainOrg'   => 'isMainOrg',
        'logoUrl'     => 'logoUrl',
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
        if (null !== $this->isMainOrg) {
            $res['isMainOrg'] = $this->isMainOrg;
        }
        if (null !== $this->logoUrl) {
            $res['logoUrl'] = $this->logoUrl;
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
        if (isset($map['isMainOrg'])) {
            $model->isMainOrg = $map['isMainOrg'];
        }
        if (isset($map['logoUrl'])) {
            $model->logoUrl = $map['logoUrl'];
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
