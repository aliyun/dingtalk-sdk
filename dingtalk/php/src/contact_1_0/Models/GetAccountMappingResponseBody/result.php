<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetAccountMappingResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example BizName1
     *
     * @var string
     */
    public $domain;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @example o_123
     *
     * @var string
     */
    public $outId;

    /**
     * @example t_123,如果不区分，填写固定值
     *
     * @var string
     */
    public $outTenantId;

    /**
     * @description This parameter is required.
     *
     * @example id_123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'domain'      => 'domain',
        'extension'   => 'extension',
        'outId'       => 'outId',
        'outTenantId' => 'outTenantId',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->domain) {
            $res['domain'] = $this->domain;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->outId) {
            $res['outId'] = $this->outId;
        }
        if (null !== $this->outTenantId) {
            $res['outTenantId'] = $this->outTenantId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain'])) {
            $model->domain = $map['domain'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['outId'])) {
            $model->outId = $map['outId'];
        }
        if (isset($map['outTenantId'])) {
            $model->outTenantId = $map['outTenantId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
