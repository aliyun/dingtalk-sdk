<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class CopyDocWithAppAuthRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sourceDentryUuid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $targetParentDentryUuid;

    /**
     * @var string
     */
    public $targetPreDentryUuid;
    protected $_name = [
        'operatorId' => 'operatorId',
        'sourceDentryUuid' => 'sourceDentryUuid',
        'targetParentDentryUuid' => 'targetParentDentryUuid',
        'targetPreDentryUuid' => 'targetPreDentryUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->sourceDentryUuid) {
            $res['sourceDentryUuid'] = $this->sourceDentryUuid;
        }
        if (null !== $this->targetParentDentryUuid) {
            $res['targetParentDentryUuid'] = $this->targetParentDentryUuid;
        }
        if (null !== $this->targetPreDentryUuid) {
            $res['targetPreDentryUuid'] = $this->targetPreDentryUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyDocWithAppAuthRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['sourceDentryUuid'])) {
            $model->sourceDentryUuid = $map['sourceDentryUuid'];
        }
        if (isset($map['targetParentDentryUuid'])) {
            $model->targetParentDentryUuid = $map['targetParentDentryUuid'];
        }
        if (isset($map['targetPreDentryUuid'])) {
            $model->targetPreDentryUuid = $map['targetPreDentryUuid'];
        }

        return $model;
    }
}
