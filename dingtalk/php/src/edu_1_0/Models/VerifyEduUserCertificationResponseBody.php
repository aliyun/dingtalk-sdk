<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class VerifyEduUserCertificationResponseBody extends Model
{
    /**
     * @var bool
     */
    public $certificated;

    /**
     * @var string
     */
    public $certificatedCorpId;

    /**
     * @var string
     */
    public $certificatedOrgName;

    /**
     * @var string
     */
    public $certificatedUserId;
    protected $_name = [
        'certificated' => 'certificated',
        'certificatedCorpId' => 'certificatedCorpId',
        'certificatedOrgName' => 'certificatedOrgName',
        'certificatedUserId' => 'certificatedUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->certificated) {
            $res['certificated'] = $this->certificated;
        }
        if (null !== $this->certificatedCorpId) {
            $res['certificatedCorpId'] = $this->certificatedCorpId;
        }
        if (null !== $this->certificatedOrgName) {
            $res['certificatedOrgName'] = $this->certificatedOrgName;
        }
        if (null !== $this->certificatedUserId) {
            $res['certificatedUserId'] = $this->certificatedUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VerifyEduUserCertificationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['certificated'])) {
            $model->certificated = $map['certificated'];
        }
        if (isset($map['certificatedCorpId'])) {
            $model->certificatedCorpId = $map['certificatedCorpId'];
        }
        if (isset($map['certificatedOrgName'])) {
            $model->certificatedOrgName = $map['certificatedOrgName'];
        }
        if (isset($map['certificatedUserId'])) {
            $model->certificatedUserId = $map['certificatedUserId'];
        }

        return $model;
    }
}
