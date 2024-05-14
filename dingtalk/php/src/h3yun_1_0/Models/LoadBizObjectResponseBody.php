<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class LoadBizObjectResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example success
     *
     * @var string
     */
    public $code;

    /**
     * @example {                 "ObjectId": "f2eef8c4-0455-4e3e-bb15-258fb409e077",                 "Name": "0000007",                 "CreatedBy": "张三",                 "OwnerId": "张三",                 "OwnerDeptId": "深圳**公司",                 "CreatedTime": "2021/11/15 17:41:11",                 "ModifiedBy": "",                 "ModifiedTime": "2021/11/15 17:41:11",                 "WorkflowInstanceId": "",                 "Status": 1,                 "F0000010": "0000007",                 "F0000011": "王五",                 "F0000012": "D1级客户",                 "F0000013": "7000",                 "F0000023": null,                 "F0000024": null,                 "D000183Fcd15f3a51e624bbc9945392d190b6aa8": [                     {                         "ObjectId": "836314cf-e25f-448b-ac79-9a0f58154299",                         "Name": null,                         "ParentObjectId": "f2eef8c4-0455-4e3e-bb15-258fb409e077",                         "F0000014": "里斯",                         "F0000015": "156********",                         "F0000016": "技术部",                         "F0000017": "经理",                         "F0000018": "男",                         "F0000019": "lgbxunmi@dd.com",                         "F0000020": true,                         "F0000021": "无"                     }                 ],                 "F0000022": null,                 "CreatedByObject": {                     "ObjectId": "aea4d7a7-d162-4c77-9c44-7bd9cb8316a5",                     "Name": "张三"                 },                 "OwnerIdObject": {                     "ObjectId": "aea4d7a7-d162-4c77-9c44-7bd9cb8316a5",                     "Name": "张三"                 },                 "OwnerDeptIdObject": {                     "ObjectId": "18f923a7-5a5e-426d-94ae-a55ad1a4b240",                     "Name": "深圳**公司"                 }             }
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @description This parameter is required.
     *
     * @example OK
     *
     * @var string
     */
    public $message;
    protected $_name = [
        'code'    => 'code',
        'data'    => 'data',
        'message' => 'message',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LoadBizObjectResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }

        return $model;
    }
}
