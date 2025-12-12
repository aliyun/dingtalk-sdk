<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRosterFieldFormRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $formId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'formId' => 'formId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRosterFieldFormRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
