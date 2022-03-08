<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPropertyInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $adminName;

    /**
     * @var string
     */
    public $adminUserId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $orgId;

    /**
     * @var string
     */
    public $unifiedSocialCredit;
    protected $_name = [
        'adminName'           => 'adminName',
        'adminUserId'         => 'adminUserId',
        'name'                => 'name',
        'orgId'               => 'orgId',
        'unifiedSocialCredit' => 'unifiedSocialCredit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminName) {
            $res['adminName'] = $this->adminName;
        }
        if (null !== $this->adminUserId) {
            $res['adminUserId'] = $this->adminUserId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->unifiedSocialCredit) {
            $res['unifiedSocialCredit'] = $this->unifiedSocialCredit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPropertyInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminName'])) {
            $model->adminName = $map['adminName'];
        }
        if (isset($map['adminUserId'])) {
            $model->adminUserId = $map['adminUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['unifiedSocialCredit'])) {
            $model->unifiedSocialCredit = $map['unifiedSocialCredit'];
        }

        return $model;
    }
}
