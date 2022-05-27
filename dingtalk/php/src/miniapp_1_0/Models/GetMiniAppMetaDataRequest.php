<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMiniAppMetaDataRequest extends Model
{
    /**
     * @var string
     */
    public $bundleId;

    /**
     * @var mixed[]
     */
    public $bundleIdTableGmtModified;

    /**
     * @var string
     */
    public $fromAppName;

    /**
     * @var mixed[]
     */
    public $miniAppIdTableGmtModified;
    protected $_name = [
        'bundleId'                  => 'bundleId',
        'bundleIdTableGmtModified'  => 'bundleIdTableGmtModified',
        'fromAppName'               => 'fromAppName',
        'miniAppIdTableGmtModified' => 'miniAppIdTableGmtModified',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bundleId) {
            $res['bundleId'] = $this->bundleId;
        }
        if (null !== $this->bundleIdTableGmtModified) {
            $res['bundleIdTableGmtModified'] = $this->bundleIdTableGmtModified;
        }
        if (null !== $this->fromAppName) {
            $res['fromAppName'] = $this->fromAppName;
        }
        if (null !== $this->miniAppIdTableGmtModified) {
            $res['miniAppIdTableGmtModified'] = $this->miniAppIdTableGmtModified;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMiniAppMetaDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bundleId'])) {
            $model->bundleId = $map['bundleId'];
        }
        if (isset($map['bundleIdTableGmtModified'])) {
            $model->bundleIdTableGmtModified = $map['bundleIdTableGmtModified'];
        }
        if (isset($map['fromAppName'])) {
            $model->fromAppName = $map['fromAppName'];
        }
        if (isset($map['miniAppIdTableGmtModified'])) {
            $model->miniAppIdTableGmtModified = $map['miniAppIdTableGmtModified'];
        }

        return $model;
    }
}
