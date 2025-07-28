<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEduUnionAuthServiceResponseBody;

use AlibabaCloud\Tea\Model;

class authInfoModels extends Model
{
    /**
     * @var string
     */
    public $authCorpId;

    /**
     * @var string
     */
    public $authCorpName;

    /**
     * @var string
     */
    public $authTime;

    /**
     * @var string[]
     */
    public $resourceNames;
    protected $_name = [
        'authCorpId' => 'authCorpId',
        'authCorpName' => 'authCorpName',
        'authTime' => 'authTime',
        'resourceNames' => 'resourceNames',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authCorpId) {
            $res['authCorpId'] = $this->authCorpId;
        }
        if (null !== $this->authCorpName) {
            $res['authCorpName'] = $this->authCorpName;
        }
        if (null !== $this->authTime) {
            $res['authTime'] = $this->authTime;
        }
        if (null !== $this->resourceNames) {
            $res['resourceNames'] = $this->resourceNames;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return authInfoModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authCorpId'])) {
            $model->authCorpId = $map['authCorpId'];
        }
        if (isset($map['authCorpName'])) {
            $model->authCorpName = $map['authCorpName'];
        }
        if (isset($map['authTime'])) {
            $model->authTime = $map['authTime'];
        }
        if (isset($map['resourceNames'])) {
            if (!empty($map['resourceNames'])) {
                $model->resourceNames = $map['resourceNames'];
            }
        }

        return $model;
    }
}
