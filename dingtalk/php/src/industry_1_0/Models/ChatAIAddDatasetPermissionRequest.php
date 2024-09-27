<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatAIAddDatasetPermissionRequest extends Model
{
    /**
     * @example user
     *
     * @var string
     */
    public $authorizationType;

    /**
     * @var string[]
     */
    public $authorizedObjectId;

    /**
     * @var int
     */
    public $datasetId;

    /**
     * @example 操作人id
     *
     * @var string
     */
    public $optUser;
    protected $_name = [
        'authorizationType'  => 'authorizationType',
        'authorizedObjectId' => 'authorizedObjectId',
        'datasetId'          => 'datasetId',
        'optUser'            => 'optUser',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorizationType) {
            $res['authorizationType'] = $this->authorizationType;
        }
        if (null !== $this->authorizedObjectId) {
            $res['authorizedObjectId'] = $this->authorizedObjectId;
        }
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->optUser) {
            $res['optUser'] = $this->optUser;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatAIAddDatasetPermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorizationType'])) {
            $model->authorizationType = $map['authorizationType'];
        }
        if (isset($map['authorizedObjectId'])) {
            if (!empty($map['authorizedObjectId'])) {
                $model->authorizedObjectId = $map['authorizedObjectId'];
            }
        }
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }
        if (isset($map['optUser'])) {
            $model->optUser = $map['optUser'];
        }

        return $model;
    }
}
