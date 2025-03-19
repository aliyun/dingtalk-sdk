<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\DeleteProjectMembersV3ResponseBody\errors;
use AlibabaCloud\Tea\Model;

class DeleteProjectMembersV3ResponseBody extends Model
{
    /**
     * @var errors[]
     */
    public $errors;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string[]
     */
    public $result;
    protected $_name = [
        'errors' => 'errors',
        'requestId' => 'requestId',
        'result' => 'result',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errors) {
            $res['errors'] = [];
            if (null !== $this->errors && \is_array($this->errors)) {
                $n = 0;
                foreach ($this->errors as $item) {
                    $res['errors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteProjectMembersV3ResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errors'])) {
            if (!empty($map['errors'])) {
                $model->errors = [];
                $n = 0;
                foreach ($map['errors'] as $item) {
                    $model->errors[$n++] = null !== $item ? errors::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['result'])) {
            if (!empty($map['result'])) {
                $model->result = $map['result'];
            }
        }

        return $model;
    }
}
